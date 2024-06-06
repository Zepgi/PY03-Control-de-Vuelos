





namespace System
{
    internal class DataGridViewRowPrePaintEventArgs
    {
        private Action<object, Windows.Forms.DataGridViewRowPrePaintEventArgs> pilotsGrid_RowPrePaint;
        private Action<object, DataGridViewRowPrePaintEventArgs> pilotsGrid_RowPrePaint1;

        public DataGridViewRowPrePaintEventArgs(Action<object, Windows.Forms.DataGridViewRowPrePaintEventArgs> pilotsGrid_RowPrePaint)
        {
            this.pilotsGrid_RowPrePaint = pilotsGrid_RowPrePaint;
        }

        public DataGridViewRowPrePaintEventArgs(Action<object, DataGridViewRowPrePaintEventArgs> pilotsGrid_RowPrePaint1)
        {
            this.pilotsGrid_RowPrePaint1 = pilotsGrid_RowPrePaint1;
        }
    }
}