using MonkeyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonkeyApp.Model;
using Xamarin.Forms;
using MonkeyApp.Service;
using System.Net.Http;
using Newtonsoft.Json;

[assembly:Dependency(typeof(WebDataStore))]
namespace MonkeyApp.Service
{
    public class WebDataStore : IDataStore
    {
        public async Task<IEnumerable<Monkey>> GetMonkeysAsync()
        {
            var client = new HttpClient();
            //var json = await client.GetStringAsync("http://montemagno.com/monkeys.json");
            var json = "[{\"Name\":\"Baboon\",\"Location\":\"Africa & Asia\",\"Details\":\"Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.\",\"Image\":\"http://upload.wikimedia.org/wikipedia/commons/thumb/9/96/Portrait_Of_A_Baboon.jpg/314px-Portrait_Of_A_Baboon.jpg\",\"Population\":10000},{\"Name\":\"Capuchin Monkey\",\"Location\":\"Central & South America\",\"Details\":\"The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.\",\"Image\":\"http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg\",\"Population\":23000},{\"Name\":\"Blue Monkey\",\"Location\":\"Central and East Africa\",\"Details\":\"The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia\",\"Image\":\"http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg\",\"Population\":12000}]";
            return JsonConvert.DeserializeObject<List<Monkey>>(json);

        }
    }
}
