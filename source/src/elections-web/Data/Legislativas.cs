using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorWasmApp.Data.Elections
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Candidato
    {
        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }

        [JsonPropertyName("votos")]
        public string Votos { get; set; }

        [JsonPropertyName("percentagem")]
        public string Percentagem { get; set; }
    }

    public class Deputado
    {
        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }
    }

    public class Regiao
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("votantes")]
        public string Votantes { get; set; }

        [JsonPropertyName("inscritos")]
        public string Inscritos { get; set; }

        [JsonPropertyName("votosBranco")]
        public string VotosBranco { get; set; }

        [JsonPropertyName("votosNulo")]
        public string VotosNulo { get; set; }

        [JsonPropertyName("votosBrancoPercento")]
        public string VotosBrancoPercento { get; set; }

        [JsonPropertyName("votosNuloPercento")]
        public string VotosNuloPercento { get; set; }

        [JsonPropertyName("candidatos")]
        public List<Candidato> Candidatos { get; set; }

        [JsonPropertyName("deputados")]
        public List<Deputado> Deputados { get; set; }
    }

    public class LegislativaResult
    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("ano")]
        public string Ano { get; set; }

        [JsonPropertyName("genScrapper")]
        public string GenScrapper { get; set; }

        [JsonPropertyName("genDate")]
        public DateTime GenDate { get; set; }

        [JsonPropertyName("regioes")]
        public List<Regiao> Regioes { get; set; }
    }


}
