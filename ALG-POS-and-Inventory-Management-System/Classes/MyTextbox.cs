using System.Drawing;
using System.Windows.Forms;
public class MyTextBox : TextBox {

    public MyTextBox() {
        BorderStyle = System.Windows.Forms.BorderStyle.None;
        AutoSize = false; //Allows you to change height to have bottom padding
        Controls.Add(new Label() { Height = 3, Dock = DockStyle.Bottom, BackColor = Color.White, });
    }
    private void Button1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
        dynamic txt = (MyTextBox)sender;
        dynamic drawBrush = new SolidBrush(txt.ForeColor);
        dynamic sf = new StringFormat {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        txt.Text = string.Empty;
        e.Graphics.DrawString("MyTextBox", txt.Font, drawBrush, e.ClipRectangle, sf);
        drawBrush.Dispose();
        sf.Dispose();

    }

    private void InitializeComponent() {
            this.SuspendLayout();
            this.ResumeLayout(false);

    }
}