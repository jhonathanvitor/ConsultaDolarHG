using Newtonsoft.Json;

namespace ConsultaDolarHG {
    public class Market {

        public Market() {
            this.Currency = new Currency();
        }

        [JsonProperty(PropertyName = "currencies")]
        public Currency Currency { get; set; }
    }
}
