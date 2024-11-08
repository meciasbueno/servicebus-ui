namespace Servicebus.Ui.WinForm.Model
{
    public class SbMessage
    {
        public long Sequence { get; set; }
        public string Label { get; set; }
        public string Body { get; set; }
        public DateTimeOffset EnqueuedTime { get; set; }
        public DateTimeOffset ExpiresAt { get; set; }

        public List<Property> Properties { get; set; }

        public void DefineGrid(DataGridView grid)
        {
            grid.Columns[nameof(Body)].Width = 350;
            grid.Columns[nameof(Body)].HeaderText = "Payload";

            grid.Columns[nameof(Label)].Width = 120;
            grid.Columns[nameof(Label)].HeaderText = "Label";

            grid.Columns[nameof(Sequence)].Width = 125;
            grid.Columns[nameof(Sequence)].HeaderText = "Seq";
            grid.Columns[nameof(Sequence)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
