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
        public int brojFaza;
        public Form2()
        {
            InitializeComponent();
            GenerateTable();
            
        }
        private void GenerateTable()
        {
            System.Drawing.Color[] boje = new System.Drawing.Color[] { System.Drawing.Color.LightBlue, System.Drawing.Color.LightCoral, System.Drawing.Color.LightGreen, System.Drawing.Color.LightSalmon};

            brojFaza = Convert.ToInt16(Form1.instance.brojFaza.Value);
            // Create a TableLayoutPanel
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 3 * (brojFaza+1) + 2,
                ColumnCount = 5,
                Dock = DockStyle.Fill,
                AutoSize = true,
                AutoScroll = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
            };

            // Define column styles
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));

            for(int i = 0; i <= tableLayoutPanel.RowCount; i++ )
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Add headers
            AddCellToTable(tableLayoutPanel, new Label() { Text = "Ime parametra", AutoSize = true, Font = new Font("Arial", 15) }, 0, 0, SystemColors.Control);
            AddCellToTable(tableLayoutPanel, new Label() { Text = "Merna jedinica", AutoSize = true, Font = new Font("Arial", 15) }, 1, 0, SystemColors.Control);
            AddCellToTable(tableLayoutPanel, new Label() { Text = "Vrednost", AutoSize = true, Font = new Font("Arial", 15) }, 2, 0, SystemColors.Control);

            // Create and size the button
            Button potvrdiButton = new Button()
            {
                Text = "potvrdi",
                Font = new Font("Arial", 15),
                AutoSize = true
            };

            // Set the button's height explicitly based on the font size and padding
            Size textSize = TextRenderer.MeasureText(potvrdiButton.Text, potvrdiButton.Font);
            int padding = 6; // You can adjust this value as needed
            potvrdiButton.Height = textSize.Height + padding;

            // Ensure the button's size is set correctly by overriding the OnLayout event
            potvrdiButton.Layout += (s, e) =>
            {
                potvrdiButton.Height = textSize.Height + padding;
            };

            AddCellToTable(tableLayoutPanel, potvrdiButton, 3, 0, SystemColors.Control);
            for (int i = 1; i <= brojFaza; i++)
            {
                AddCellToTable(tableLayoutPanel, new Label() { Text = i + ". Brzina zagrevanja", Dock = DockStyle.Fill, AutoSize = true, Font = new Font("Arial", 15) }, 0, 3*i, boje[i%4]);
                AddCellToTable(tableLayoutPanel, new Label() { Text = "°C/h", Dock = DockStyle.Fill, AutoSize = true, Font = new Font("Arial", 15) }, 1, 3 * i, boje[i%4]);
                TextBox valueTextBox1 = new TextBox() { AutoSize = true, Dock = DockStyle.Fill }; // Editable text box for value
                AddCellToTable(tableLayoutPanel, valueTextBox1, 2, 3 * i, boje[i%4]);

                AddCellToTable(tableLayoutPanel, new Label() { Text = i + ". Temperatura", Dock = DockStyle.Fill, AutoSize = true, Font = new Font("Arial", 15) }, 0, 3 * i + 1, boje[i%4]);
                AddCellToTable(tableLayoutPanel, new Label() { Text = "°C", Dock = DockStyle.Fill, AutoSize = true, Font = new Font("Arial", 15) }, 1, 3 * i + 1, boje[i%4]);
                TextBox valueTextBox2 = new TextBox() { AutoSize = true, Dock = DockStyle.Fill }; // Editable text box for value
                AddCellToTable(tableLayoutPanel, valueTextBox2, 2, 3 * i + 1, boje[i%4]);

                AddCellToTable(tableLayoutPanel, new Label() { Text = i + ". Zadrška", Dock = DockStyle.Fill, AutoSize = true, Font = new Font("Arial", 15) }, 0, 3 * i + 2, boje[i%4]);
                AddCellToTable(tableLayoutPanel, new Label() { Text = "min", Dock = DockStyle.Fill, AutoSize = true, Font = new Font("Arial", 15) }, 1, 3 * i + 2, boje[i%4]);
                TextBox valueTextBox3 = new TextBox() { AutoSize = true, Dock = DockStyle.Fill }; // Editable text box for value
                AddCellToTable(tableLayoutPanel, valueTextBox3, 2, 3 * i + 2, boje[i%4]);
            }
            // Add the TableLayoutPanel to the form
            this.Controls.Add(tableLayoutPanel);
        }

        private void AddCellToTable(TableLayoutPanel table, Control control, int column, int row, Color backColor)
        {
            control.BackColor = backColor;
            table.Controls.Add(control, column, row);
        }

        private void AddCellToTable(TableLayoutPanel table, Control control, int column, int row, Color backColor, int colspan)
        {
            control.BackColor = backColor;
            table.Controls.Add(control, column, row);
            table.SetColumnSpan(control, colspan);
        }
    }
}
