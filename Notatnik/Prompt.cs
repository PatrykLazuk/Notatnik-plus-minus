using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public class Prompt
    {
        public static bool ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 110, Top = 20, Text = text };
            Button confirmation = new Button() { Text = "Delete", Left = 40, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            Button decline = new Button() { Text = "Decline", Left = 140, Width = 100, Top = 70, DialogResult = DialogResult.Cancel };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            decline.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(decline);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = decline;

            return prompt.ShowDialog() == DialogResult.OK ? true : false;
        }
    }
}
