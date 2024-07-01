using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pid_tabela
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            GenerateTable();
        }
        private void GenerateTable()
        {
            // Create a TableLayoutPanel
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 3, // Increased to 3 rows
                ColumnCount = 3,
                Dock = DockStyle.Fill,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
            };

            // Define column styles
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));

            // Define row styles (AutoSize ensures rows grow to fit their contents)
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Set to AutoSize for fixed height

            // Add headers
            AddCellToTable(tableLayoutPanel, new Label() { Text = "Ime parametra", AutoSize = true, Font = new Font("Arial", 15) }, 0, 0, SystemColors.Control);
            AddCellToTable(tableLayoutPanel, new Label() { Text = "Merna jedinica", AutoSize = true, Font = new Font("Arial", 15) }, 1, 0, SystemColors.Control);
            AddCellToTable(tableLayoutPanel, new Label() { Text = "Vrednost", AutoSize = true, Font = new Font("Arial", 15) }, 2, 0, SystemColors.Control);

            // Add data row with custom background color
            AddCellToTable(tableLayoutPanel, new Label() { Text = "Brzina zagrevanja", AutoSize = true, Font = new Font("Arial", 15) }, 0, 1, System.Drawing.Color.LightBlue);
            AddCellToTable(tableLayoutPanel, new Label() { Text = "°C/h", AutoSize = true, Font = new Font("Arial", 15) }, 1, 1, System.Drawing.Color.LightBlue);
            TextBox valueTextBox = new TextBox() { AutoSize = true, Dock = DockStyle.Fill }; // Editable text box for value
            AddCellToTable(tableLayoutPanel, valueTextBox, 2, 1, System.Drawing.Color.LightBlue);

            // Add the TableLayoutPanel to the form
            this.Controls.Add(tableLayoutPanel);
        }

        private void AddCellToTable(TableLayoutPanel table, Control control, int column, int row, System.Drawing.Color backgroundColor)
        {
            Panel panel = new Panel { Dock = DockStyle.Fill, BackColor = backgroundColor, Padding = new Padding(0), AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            control.Dock = DockStyle.Fill;
            control.AutoSize = true;
            panel.Controls.Add(control);
            table.Controls.Add(panel, column, row);
        }
    }
}
