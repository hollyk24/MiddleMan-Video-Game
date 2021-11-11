using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace StateDesignPattern {
    public interface MenuState {
        void BeforeGame();
        void Ingame();
        void PausedGame();

    }
}
