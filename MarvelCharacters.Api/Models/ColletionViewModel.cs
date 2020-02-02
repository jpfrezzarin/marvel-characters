using System.Collections.Generic;

namespace MarvelsCharacters.Api.Models
{
    public class ColletionViewModel<T>
    {
        public int Available { get; set; }
        public string CollectionUri { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
