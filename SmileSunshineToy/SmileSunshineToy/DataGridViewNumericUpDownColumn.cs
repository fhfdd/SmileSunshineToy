using System;

namespace SmileSunshineToy
{
    internal class DataGridViewNumericUpDownColumn
    {
        public string Name { get; internal set; }
        public int Minimum { get; internal set; }
        public Type ValueType { get; internal set; }
        public int Maximum { get; internal set; }
        public string HeaderText { get; internal set; }
    }
}