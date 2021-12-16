using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace KOS.Elections.Dataviz.Data.Aut
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Candidato
    {
        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }

        [JsonPropertyName("votos")]
        public string Votos { get; set; }
    }

    public class Eleito
    {
        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }
    }

    public class Assembleia
    {
        [JsonPropertyName("orgao")]
        public string Orgao { get; set; }

        [JsonPropertyName("votantes")]
        public string Votantes { get; set; }

        [JsonPropertyName("inscritos")]
        public string Inscritos { get; set; }

        [JsonPropertyName("votosBranco")]
        public string VotosBranco { get; set; }

        [JsonPropertyName("votosNulo")]
        public string VotosNulo { get; set; }

        [JsonPropertyName("candidatosResultados")]
        public List<Candidato> CandidatosResultados { get; set; }

        [JsonPropertyName("eleitos")]
        public List<Eleito> Eleitos { get; set; }
    }


    public class Camara
    {
        [JsonPropertyName("orgao")]
        public string Orgao { get; set; }

        [JsonPropertyName("votantes")]
        public string Votantes { get; set; }

        [JsonPropertyName("inscritos")]
        public string Inscritos { get; set; }

        [JsonPropertyName("votosBranco")]
        public string VotosBranco { get; set; }

        [JsonPropertyName("votosNulo")]
        public string VotosNulo { get; set; }

        [JsonPropertyName("candidatosResultados")]
        public List<Candidato> CandidatosResultados { get; set; }

        [JsonPropertyName("eleitos")]
        public List<Eleito> Eleitos { get; set; }
    }

    public class Municipio
    {
        [JsonPropertyName("circuloNome")]
        public string CirculoNome { get; set; }

        [JsonPropertyName("circuloURL")]
        public string CirculoURL { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("assembleia")]
        public Assembleia Assembleia { get; set; }

        [JsonPropertyName("camara")]
        public Camara Camara { get; set; }
    }

    public class AutarquicaResult
    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("ano")]
        public string Ano { get; set; }

        [JsonPropertyName("genScrapper")]
        public string GenScrapper { get; set; }

        [JsonPropertyName("genDate")]
        public DateTime GenDate { get; set; }

        [JsonPropertyName("municipios")]
        public List<Municipio> Municipios { get; set; }
    }
}
