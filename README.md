# First-3D-FPS-Team-project  <br/>
 
Description of the project : <br/>
-This is a team school project that we had 12-13 weeks. <br/>
-We did a first person shooter with somes puzzles, platforms and enemies(AI). <br/>
-We did everything Except assets and sounds. <br/>
-This projet use new input system. <br/>
Unity Game Engine version used : 2021.1.17f1. <br/>

What I did : <br/>
-Enemies : <br/>
-I mostly did AI on enemies with the NavMeshAgent Component.<br/>
-I did common Behaviour like patrol, chasse, melee attack, range attack. <br/>
-I did a token behaviour to have a maximun number of enemies on the player at the time. <br/>
-I create a Area system for enemies to always stay in their start area.<br/>
-I used animation event to control specifics animations behaviour. <br/>
-I did a enemie manager to control the enemie respawn.<br/>
-I used scriptableobject to set enemies stats.<br/>
-I have a impulse force if ennemie touchj the player. <br/>
-I used heritage in my script (Enemie) for common behaviour.<br/>
*See enemies scripts for more details.( all of the scripts I did are in Assets/Enemies)<br/>
 First time I did AI so some bug have taken time to be fixes.<br/>
 
 Player: <br/>
-I did Player checkpoint and respawn system using sciptableobject. <br/>
-I create a system to have a random puzzle order and color each time you enter in the "steven" map part. <br/>
-I did a count system to be able to open doors. <br/>

Game Controls : <br/>
-w,a,s,d to move.<br/>
-mouse to look around.<br/>
-space to jump.<br/>
-shift to run.<br/>
-shift + c to slide.<br/>
-left click to shoot.<br/>
-right click mouse to aim.<br/>
-1,2,3,4 to change the gun. <br/>

Sources :<br/>
-NavMeshAgent :
Unity-Technologies, «NavMeshAgent», github, 21 july 2020, https://github.com/Unity-Technologies/NavMeshComponents, consulted 17 january.

-Gun Asset :
Taylor Huff, «Sci-Fi Weapons», DevAssets, 9 april 2017, https://devassets.com/assets/sci-fi-weapons/#!/ , consulted 17 january.

-Particule effect :
Unity-Technologies, «Standard Assets», Unity Asset Store, 8 april 2020, https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2018-4-32351#releases, consulted 15 march.

-Gun CrossHair :
AssetBag « Crosshairs Plus ». Unity Asset Store, April 2019, https://assetstore.unity.com/packages/2d/gui/icons/crosshairs-plus-139902. Consulted January 25th 2022.

-Skybox :
Avionx, «Skybox Series Free», AssetStore, Jan 4 2022, https://assetstore.unity.com/packages/2d/textures-materials/sky/skybox-series-free-103633 , consulted march 15th.

-Visual Assets : Unity Technologies. « 3D Game Kit ». Unity Asset Store, https://assetstore.unity.com/packages/templates/tutorials/3d-game-kit-115747. Consulted January 20th 2022.

-Music and SFX :
   Mark Johnson. « Free Sound Effects ». Gfx Sounds, https://gfxsounds.com/free-sound-effects/. Consulted April 6th 2022.
   TuneTank. « The Time ». Music Area, https://tunetank.com/tracks/3935-the-time/. Consulted April 11th 2022.
   AV Productions. « Stone slide sound effects all sounds. Tomb Opening Sounds ~ How to make Indiana Jones Sounds ». Youtube,
   YouTube,https://www.youtube.com/watch?v=pOsHnymziis. Consulted April 6th 2022.
