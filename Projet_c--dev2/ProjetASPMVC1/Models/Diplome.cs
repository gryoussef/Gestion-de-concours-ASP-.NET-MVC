﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetASPMVC1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Diplome
    {

        public Diplome()
        {
            this.Candidats = new HashSet<Candidat>();
        }
        [Key]
        public int id_diplome { get; set; }
        [Required]
        public string nom_diplome { get; set; }
        [Required]
        public string ville_diplome { get; set; }
        [Required]
        public string etablissement { get; set; }
        [Required]
        public string scan_dip { get; set; }
        public virtual ICollection<Candidat> Candidats { get; set; }
        public virtual ICollection<corbeil> Corbeil{ get; set; }
    }
}
