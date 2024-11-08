namespace Servicebus.Ui.WinForm.Model
{
    public class Property
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public void DefineGrid(DataGridView grid)
        {
            grid.Columns[nameof(Key)].Width = 120;
            grid.Columns[nameof(Value)].Width = 130;
        }
    }
}
