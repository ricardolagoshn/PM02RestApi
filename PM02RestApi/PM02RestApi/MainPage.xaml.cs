using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static PM02RestApi.Countries;
using PM02RestApi;

namespace PM02RestApi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnRestApi_Clicked(object sender, EventArgs e)
        {

            var coordenadas = Plugin.Geolocator.CrossGeolocator.Current;
            var posicion = await coordenadas.GetPositionAsync();

            list.ItemsSource =  await AppClass.Metodos.getSites(posicion.Latitude, posicion.Longitude);

            #region test
                    /*
                  var url = "https://restcountries.eu/rest/v2/region/europe";

                  var urlfq = Sitios.getUrl(14.66, -88.05);

                  using (HttpClient cliente = new HttpClient())
                  {
                      var Respuesta = await cliente.GetAsync(url);

                      if (Respuesta.IsSuccessStatusCode)
                      {
                          var json =  Respuesta.Content.ReadAsStringAsync().Result;

                          await DisplayAlert("Respuesta", json, "OK");

                          var Paises = JsonConvert.DeserializeObject<List<CountriesREst>>(json);



                      }

                  }
                  */
            #endregion

        }
    }
}
