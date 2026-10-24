using System.Threading.Tasks;

namespace Foto
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async Task ButtonTirarFoto_Clicked(object sender, EventArgs e)
        {
            try
            {
                if(!MediaPicker.Default.IsCaptureSupported)
                {
                    await DisplayAlert("câmera","Este dispositivo não possui suporte para a captura de fotos.","OK");
                    
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
