namespace NewsApp.Views;
using NewsApp.dto;

public partial class NoticiasView : ContentPage
{
	public NoticiasView()
	{



		InitializeComponent();
        List<Test> data = new List<Test>() {
                new Test{ Titulo = "Prueba", Fecha = DateTime.Now, ImgSource = "https://static.vecteezy.com/system/resources/previews/020/934/651/original/doraemon-free-free-vector.jpg" },
                new Test{ Titulo = "Prueba2", Fecha = DateTime.Now, ImgSource = "https://static.vecteezy.com/system/resources/previews/020/934/651/original/doraemon-free-free-vector.jpg" },
                new Test { Titulo = "Prueba3", Fecha = DateTime.Now, ImgSource = "https://static.vecteezy.com/system/resources/previews/020/934/651/original/doraemon-free-free-vector.jpg" }
        };
        listaNoticias.ItemsSource = data;
    }
   
}