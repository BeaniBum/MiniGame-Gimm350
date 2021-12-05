using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Blocks to implement*/
/*Straight, Slope, U-Turn, Hole */
namespace Methods
{
    public abstract class BlockMethods
    {
        //void 
        public abstract void createMap(int width/*x*/, int length/*z*/, int height/*y*/, GameObject filler);
        public abstract void place(GameObject selected, GameObject touched, bool pressed);
        public abstract void rotate(GameObject selected, string direction, bool pressed);
        public abstract void move(GameObject selected, GameObject replacement, bool pressed);
        public abstract void delete(GameObject touched, bool pressed);
        public abstract void start(GameObject marble, GameObject start);
        public abstract void resetMarble(GameObject marble, GameObject start);
    }
}

