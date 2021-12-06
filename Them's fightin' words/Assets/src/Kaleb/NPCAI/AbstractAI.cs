using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FightCharacter;

namespace FightAI {

    public abstract class AbstractAI {
        public NPC User;
        public float Distance;//The distance between the NPC and their enemy

        //Record of past actions
        public int MaxRecord; // The maximum number of stored records for this AI type.
        public int QueueLength;
        public List<int> ActionRecord;

        public abstract void Decide();

        public void UpdateDistance(float dist) {
            Distance = dist;
        }

        public void UpdateRecord(int action) {
            ActionRecord.Add(action);
            QueueLength++;
            if(QueueLength > MaxRecord) {
                ActionRecord.RemoveAt(0);
                QueueLength--;
            }
        }

    }
}