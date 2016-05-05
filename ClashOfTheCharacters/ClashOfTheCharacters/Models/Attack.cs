﻿using ClashOfTheCharacters.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClashOfTheCharacters.Models
{
    public class Attack
    {
        public int Id { get; set; }

        public int Damage { get; set; }

        public int DefenderHpRemaining { get; set; }

        public int AttackerHpRemaining { get; set; }

        public bool FinishingBlow { get { return DefenderHpRemaining == 0 ? true : false; } }

        public Effect Effect { get; set; }

        public int BattleId { get; set; }
        public virtual Battle Battle { get; set; }

        public int? AttackerId { get; set; }
        public virtual BattleCreature Attacker { get; set; }

        public int? DefenderId { get; set; }
        public virtual BattleCreature Defender { get; set; }
    }
}