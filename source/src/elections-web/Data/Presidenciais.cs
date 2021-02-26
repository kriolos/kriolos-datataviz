using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorWasmApp.Data.Elections.Presidencial
{

    // PresidencialResult myDeserializedClass = JsonSerializer.Deserialize<PresidencialResult>(myJsonResponse);
    public class Candidato
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("votos")]
        public string Votos { get; set; }
    }

    public class Regiao
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("inscritos")]
        public string Inscritos{ get; set; }

        [JsonPropertyName("votantes")]
        public string Votantes{ get; set; }

        [JsonPropertyName("abstencao")]
        public string Abstencao{ get; set; }

        [JsonPropertyName("votosValido")]
        public string VotosValido{ get; set; }

        [JsonPropertyName("votosNulo")]
        public string VotosNulo{ get; set; }

        [JsonPropertyName("votosBranco")]
        public string VotosBranco{ get; set; }

        [JsonPropertyName("candidatos")]
        public List<Candidato> Candidatos{ get; set; }
    }

    public class PresidencialResult
    {
        [JsonPropertyName("titulo")]
        public string Titulo{ get; set; }

        [JsonPropertyName("ano")]
        public string Ano{ get; set; }

        [JsonPropertyName("genScrapper")]
        public string GenScrapper{ get; set; }

        [JsonPropertyName("genDate")]
        public DateTime GenDate{ get; set; }

        [JsonPropertyName("regioes")]
        public List<Regiao> Regioes{ get; set; }
    }
}
