namespace IntelligentVacuum.Agent
{
    using System;
    using System.Collections.Generic;
    using Environments;

    public class Agent
    {
        private Random rand = new Random();
        
        public Agent()
        {
        }

        public AgentAction DecideAction(Room room)
        {
            AgentAction action = new AgentAction();

            if (room.IsDirty){
                action = AgentAction.CLEAN;
            } else {
                int direction = rand.Next(0,4);
                switch (direction)
                {
                    case 0:
                        action = AgentAction.MOVE_UP;
                        break;
                    case 1:
                        action = AgentAction.MOVE_LEFT;
                        break;
                    case 2:
                        action = AgentAction.MOVE_DOWN;
                        break;
                    case 3:
                    default:
                        action = AgentAction.MOVE_RIGHT;
                        break;
                }
            }
            return action;
        }
    }
}