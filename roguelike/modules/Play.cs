﻿using System;
using System.Collections.Generic;

namespace roguelike.modules {
    class Play : ModuleBase {
        private string _playerName = "";

        protected override State getModuleState() {
            return State.Play;
        }

        protected override bool initModule(IList<object> parameters) {
            if (parameters.Count == 0) {
                //we didn't get player name, so transition to name entry module
                transitionToState(State.NameEntry);
            }



            return true;
        }

        protected override void runModule() {
            throw new NotImplementedException();
        }
    }
}