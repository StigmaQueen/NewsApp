namespace NewsApp.Views;
using NewsApp.dto;

public partial class NoticiasAdminView : ContentPage
{
	public NoticiasAdminView()
	{
		InitializeComponent();
        List<Test> data = new List<Test>() {
                new Test{ Titulo = "Esta es la imagen de NGC 346, un punto en el que se entremezclan polvo y los restos de una explosión (NASA)", Fecha = DateTime.Now, ImgSource = "https://www.caracteristicass.de/wp-content/uploads/2022/06/caracteristicas-de-andromeda-1024x576.jpg" },
                new Test{ Titulo = "Prueba2", Fecha = DateTime.Now, ImgSource = "https://www.caracteristicass.de/wp-content/uploads/2022/06/caracteristicas-de-andromeda-1024x576.jpg" },
                new Test { Titulo = "Prueba3", Fecha = DateTime.Now, ImgSource = "https://www.caracteristicass.de/wp-content/uploads/2022/06/caracteristicas-de-andromeda-1024x576.jpg" }
        };
        listaNoticias.ItemsSource = data;
    }
}