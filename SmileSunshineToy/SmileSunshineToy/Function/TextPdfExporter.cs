using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SmileSunshineToy
{
    public static class TextPdfExporter
    {
        public static bool ExportDataGridViewToPdf(DataGridView dgv, ExportSettings settings = null)
        {
            settings = settings ?? new ExportSettings
            {
                FontName = "Segoe UI",
                HeaderAlignment = TextAlignment.Left
            };

            var rowsToExport = GetRowsToExport(dgv);
            if (rowsToExport.Count == 0)
            {
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var columnWidths = CalculateColumnWidths(dgv, rowsToExport, settings);

            var sb = new StringBuilder();
            BuildReportHeader(sb, settings);
            BuildProductionPlan(sb, dgv, rowsToExport, columnWidths, settings);

            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = settings.FileFilter;
                saveDialog.FileName = $"ProductionPlan_{DateTime.Now:yyyyMMdd}";
                saveDialog.Title = "Export Production Plan";
                saveDialog.DefaultExt = "pdf";

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return false;

                return PrintToPdf(sb.ToString(), saveDialog.FileName, settings);
            }
        }

        private static List<DataGridViewRow> GetRowsToExport(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                return dgv.SelectedRows.Cast<DataGridViewRow>().ToList();
            }
            else if (dgv.Rows.Count > 0)
            {
                var result = MessageBox.Show("No rows selected. Export all data?",
                    "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                return result == DialogResult.Yes ?
                    dgv.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow).ToList() :
                    new List<DataGridViewRow>();
            }
            return new List<DataGridViewRow>();
        }

        private static int[] CalculateColumnWidths(DataGridView dgv, List<DataGridViewRow> rows, ExportSettings settings)
        {
            var widths = new int[dgv.Columns.Count];

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (!dgv.Columns[i].Visible) continue;

                int maxWidth = GetTextWidth(dgv.Columns[i].HeaderText);

                foreach (var row in rows)
                {
                    string cellText = row.Cells[i].FormattedValue?.ToString() ?? "";
                    maxWidth = Math.Max(maxWidth, GetTextWidth(cellText));
                }

                widths[i] = Math.Min(
                    Math.Max(maxWidth, settings.MinColumnWidth),
                    settings.MaxColumnWidth
                );
            }
            return widths;
        }

        private static int GetTextWidth(string text)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            return text.Sum(c => c > 255 ? 2 : 1) + 2;
        }

        private static void BuildReportHeader(StringBuilder sb, ExportSettings settings)
        {
            sb.AppendLine("Production Plan Report");
            sb.AppendLine($"Date: {DateTime.Now:yyyy-MM-dd}");
            sb.AppendLine();
        }

        private static void BuildProductionPlan(StringBuilder sb, DataGridView dgv,
            List<DataGridViewRow> rows, int[] columnWidths, ExportSettings settings)
        {
            // Column headers
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (!dgv.Columns[i].Visible) continue;
                sb.Append(PadRight(dgv.Columns[i].HeaderText, columnWidths[i], settings.HeaderAlignment));
            }
            sb.AppendLine();

            // Data rows
            foreach (var row in rows)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (!dgv.Columns[i].Visible) continue;
                    string cellValue = row.Cells[i].FormattedValue?.ToString() ?? "";
                    sb.Append(PadRight(cellValue, columnWidths[i], settings.Alignment));
                }
                sb.AppendLine();
            }

            // Summary
            sb.AppendLine();
            sb.AppendLine($"Total Plans: {rows.Count}");
        }

        private static bool PrintToPdf(string content, string filePath, ExportSettings settings)
        {
            using (var printDoc = new PrintDocument())
            {
                printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                printDoc.PrinterSettings.PrintToFile = true;
                printDoc.PrinterSettings.PrintFileName = filePath;

                printDoc.PrintPage += (sender, e) =>
                {
                    using (var font = new Font(settings.FontName, settings.FontSize))
                    using (var boldFont = new Font(settings.FontName, settings.FontSize, FontStyle.Bold))
                    {
                        float yPos = e.MarginBounds.Top;
                        bool isFirstLine = true;

                        foreach (var line in content.Split('\n'))
                        {
                            var currentFont = isFirstLine ? boldFont : font;
                            e.Graphics.DrawString(line, currentFont, Brushes.Black, e.MarginBounds.Left, yPos);
                            yPos += currentFont.GetHeight(e.Graphics);
                            isFirstLine = false;
                        }
                    }
                };

                try
                {
                    printDoc.Print();
                    if (settings.ShowSuccessMessage)
                    {
                        MessageBox.Show("Export successful!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Export failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private static string PadRight(string text, int length, TextAlignment alignment)
        {
            int textWidth = text.Sum(c => c > 255 ? 2 : 1);
            int padding = Math.Max(0, length - textWidth);

            switch (alignment)
            {
                case TextAlignment.Center:
                    int left = padding / 2;
                    return new string(' ', left) + text + new string(' ', padding - left);
                case TextAlignment.Right:
                    return new string(' ', padding) + text;
                default:
                    return text + new string(' ', padding);
            }
        }
    }

    public class ExportSettings
    {
        public string FileFilter { get; set; } = "PDF Files (*.pdf)|*.pdf";
        public string DefaultFileName { get; set; } = "ProductionPlan";
        public string FontName { get; set; } = "Arial";
        public float FontSize { get; set; } = 10f;
        public TextAlignment Alignment { get; set; } = TextAlignment.Left;
        public TextAlignment HeaderAlignment { get; set; } = TextAlignment.Left;
        public int MinColumnWidth { get; set; } = 12;
        public int MaxColumnWidth { get; set; } = 35;
        public bool ShowSuccessMessage { get; set; } = true;
    }

    public enum TextAlignment { Left, Center, Right }
}