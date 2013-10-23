using System.Windows.Forms;

namespace Snake.Model
{
    /// <summary>
    ///     События на поле
    /// </summary>
    public interface IMapEvents
    {
        void ДобавитьКартинку(PictureBox picture);
        void УбратьКартинку(PictureBox picture);
    }
}