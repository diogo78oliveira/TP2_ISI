using System.Drawing;
using System.Windows.Forms;

public class RoundedTextBox : TextBox
{
    // Define o raio dos cantos arredondados
    public int BorderRadius { get; set; } = 10;

    public RoundedTextBox()
    {
        this.BorderStyle = BorderStyle.None;  // Remover bordas padrão
        this.SetStyle(ControlStyles.UserPaint, true);  // Habilitar customização do desenho
    }

    // Método responsável por desenhar o controle
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Definir a cor da borda e o estilo
        using (Pen pen = new Pen(Color.White, 2))
        {
            // Criar um rectangulo arredondado para a borda
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawArc(pen, 0, 0, BorderRadius * 2, BorderRadius * 2, 180, 90);
            e.Graphics.DrawArc(pen, this.Width - BorderRadius * 2, 0, BorderRadius * 2, BorderRadius * 2, 270, 90);
            e.Graphics.DrawArc(pen, 0, this.Height - BorderRadius * 2, BorderRadius * 2, BorderRadius * 2, 90, 90);
            e.Graphics.DrawArc(pen, this.Width - BorderRadius * 2, this.Height - BorderRadius * 2, BorderRadius * 2, BorderRadius * 2, 0, 90);

            e.Graphics.DrawLine(pen, BorderRadius, 0, this.Width - BorderRadius, 0);
            e.Graphics.DrawLine(pen, this.Width, BorderRadius, this.Width, this.Height - BorderRadius);
            e.Graphics.DrawLine(pen, BorderRadius, this.Height, this.Width - BorderRadius, this.Height);
            e.Graphics.DrawLine(pen, 0, BorderRadius, 0, this.Height - BorderRadius);
        }

        // Preencher o fundo com uma cor
        using (SolidBrush brush = new SolidBrush(Color.FromArgb(30, 30, 30)))
        {
            e.Graphics.FillRectangle(brush, BorderRadius, 0, this.Width - BorderRadius * 2, this.Height);
        }

        // Desenhar o texto
        TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Rectangle(10, 0, this.Width - 20, this.Height), this.ForeColor);
    }
}
