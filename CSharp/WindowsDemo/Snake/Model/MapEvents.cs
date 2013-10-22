using System.Windows.Forms;

namespace Snake.Model
{
    /// <summary>
    /// События на поле
    /// </summary>
    public interface MapEvents
    {
        void Добавить(PictureBox picture);
        void Убрать(PictureBox picture);
    }
}