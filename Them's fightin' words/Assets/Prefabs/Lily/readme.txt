{\rtf1\ansi\ansicpg1252\deff0\nouicompat{\fonttbl{\f0\fnil\fcharset0 Calibri;}{\f1\fnil Consolas;}{\f2\fnil\fcharset0 Consolas;}}
{\colortbl ;\red0\green0\blue0;\red46\green117\blue182;\red163\green21\blue21;}
{\*\generator Riched20 10.0.19041}\viewkind4\uc1 
\pard\sa200\sl276\slmult1\f0\fs22\lang9 Prefab: NPC\par
Purpose: A NPC that can be placed in world and edited to be any needed NPC\par
Interactions: Has a trigger box that allows the player to initiate a conversation\par
\par
PREFAB SETUP\par
For the sprite chosen, have 4 portrait headshots of differnet emotions to put into the portraits componet\par
Create a json file for the conversation.\par
of this format. can have as many subsections\par
\cf1\f1\fs19\{\par
  \cf2 "dialog"\cf1 : [\par
\par
    \{\par
      \cf2 "text"\cf1 : \cf3 "on days like these, kids like you... Should be burning in hell."\cf1 ,\par
      \cf2 "emotion"\cf1 : 0,\par
      \cf2 "playerDialog"\cf1 : \{\par
        \cf2 "text"\cf1 : \cf3 "[1] Wait!\\n[2] I have'nt even said anything yet..."\cf1 ,\par
        \cf2 "emotion"\cf1 : 2,\par
        \cf2 "deltaJump"\cf1 : [ 0, 0, 0 ],\par
        \cf2 "angerDelta"\cf1 : [ 0, 0, 0 ]\par
      \}\par
    \},\par
    \{\par
      \cf2 "text"\cf1 : \cf3 "it's a beautiful day outside. birds are singing, flowers are blooming..."\cf1 ,\par
      \cf2 "emotion"\cf1 : 0,\par
      \cf2 "playerDialog"\cf1 : \{\par
        \cf2 "text"\cf1 : \cf3 "[1] sure is"\cf1 ,\par
        \cf2 "emotion"\cf1 : 0,\par
        \cf2 "deltaJump"\cf1 : [ 1, 1, 1 ],\par
        \cf2 "angerDelta"\cf1 : [ 99, 99, 99 ]\par
      \}\par
    \}\par
  ]\par
\} \par
\par
\f2\lang1033 the first dialog entery is what is spoken when about to enter a fight\par
the first section applies to the NPC. \par
delta jump is how it jumps through the tree linearly as options are chosen. Maybe negative values.\par
anger delta is how angery the NPC gets over that dialog option\cf0\f0\fs22\lang9\par
}
 