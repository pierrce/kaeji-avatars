> MMD model data: Tda-style NERU AKITA (one-piece dress) edit by vk

MikuMikuDance				Author: Higuchi Yu
VPVP					http://www.geocities.jp/higuchuu4/index.htm

Neru Akita				Author: Smith Hioka
Boukaloid "Neru Akita" Webry Blog	http://akita-neru.at.webry.info/


[CREDITS]
Tda: Tda-style Append Hatsune Miku
Yamamoto: One-piece dress edit
Jaaku no Keshin Baretta!!: No makeup edit
Masisi: Glasses2 model
AGA: Swimsuit Miku edit (abdomen and skin texture) 


[NOTES]
This is a Neru Akita model that I edited from Tda's Append Miku, which was clothed in a one-piece dress by Yamamoto, and with her makeup removed by Jaaku na Keshin Baretta!!.
The general appearance of my Neru Akita edits is heavily influenced by Mug_orz's Neru Akita art.

Since MMD Cup 9, I've changed and fixed many aspects of this model, but I understand that many people liked how it was.
To accommodate those people, I've included a customizable version with many mesh and colour morphs. Feel free to create your own preferred Neru.
The non-customizable version is simple and also the final revision. If I make more Neru edits, they'll use that final revision as the base.

If the model isn't showing up properly because of PMX morphs, you can use MikuMikuEffect's SubsetExtract to disable parts (eg. using barefoot, but tights appear in reflections).
When using shaders (eg. AdultShader, MassLight, Figure), I recommend using PMD Editor and under the materials section, import the included "shaded_face00_material.csv" (or material_C for the custom version).
Alternatively, you can manually edit the model's Face00 material to tick "Self-shadow" and set Toon to "tex/toon_skin.bmp".

* When using with MikuMikuOnline, it is necessary to copy "basic_run_toeIKfix.vmd" into MikuMikuOnline's "motions" folder.



[CONTENTS]
- Tda style Neru Akita one-piece
- Tda style Neru Akita one-piece customizable version (also uses an alternate face texture)
- Optional alternate dress transparency textures (dress1.png, dress2.png)
- Tda Style Neru Akita for Miku Miku Online (not updated, and includes edited walking motion to fix leg IK problem)
- Bonus: preset motions and Neru motions seen in my MMD Cup 9 video @ http://nicovideo.jp/watch/sm18668941)
- Bonus: old version ponytail model and dress rigid bodies CSV file (if there are any problems with the ponytail and dress, try using these old versions)
- Bonus: Face00 material CSV file (for use with shaders)
- Bonus: alternate darker textures (for use with shaders, but outdated now)
- Bonus: Tda style Neru Akita one-piece test version (used in the model introduction video, has Look IK, Arm IK, etc.)
- Bonus: v1.02 and v1.03 rigid bodies CSV file, and v1.02 face textures
- Bonus: old versions of models and textures

* The bonus MMD Cup 9 Neru motions don't include arm motions because the MMD Cup 9 Neru model uses a different bone setup.



[TERMS OF USE]
Refer to the readmes by the other creators for the terms of use (particularly Tda's). Their terms of use take priority over mine.
I'm not responsible for any weird trouble that might result from distributing this model.

I know how futile it is to prohibit re-distribution and editing, but please be reasonable and try to follow the other creators' wishes.
At the very least, please give proper credit to myself (vk), Tda, Yamamoto, Jaaku no Keshin Baretta!! and AGA.
I encourage making nice new clothes for this model.

Editing this model is okay, but if you use this model's face for another character, please edit it to avoid every character having the same face. Even a little bit is fine.
You can make the face different by loading the customizable version in PMD Editor, click T for Transform View, then adjust the sliders and export the morphed face as a new model.
Note that you can set morphs to negative numbers in PMD Editor's Transform View, and the hotkeys to export the current morphs as a new model are Alt+F, then S (also in Transform View).

I'd like people to try and understand how much time, effort and skill it takes to make high-quality models and textures.
Most people don't have much free time and are busy with their jobs and lives. Making 3D assets is a full-time paid job, where artists are usually paid by the hour,
MMD creators do this for free and share their work so that everyone can enjoy it. If it wasn't for those people, we wouldn't have all of these great things.
The least we can do in return is to appreciate their efforts and respect their wishes.



[CHANGES] (based from Tda-style Append Miku one-piece without makeup)

Mesh:
- Widened and rounded the face slightly
- Pinched and raised the nose
- Raised and narrowed the mouth
- Widened and reshaped eyes to be more slanted
- Removed excess eyelash verts
- Changed eyebrow shape and thickness
- Curled hair outwards, left side bangs shortened
- Modified head-hair mesh with new texture
- Made new ahoge
- Modified ponytail shape to be larger
- Changed height and body proportions to be smaller and shorter
- Forearm and leg shape/curvature changed
- Added a shirt and pantyhose
- Added abdomen under dress (disabled by default to avoid clipping)
- Modified shoe mesh shape and added strap
- Merged points of head mesh and neck mesh
- Removed bell, sash and flower
- Enlargened chest (because Neru is usually bigger than Miku)

Topology/Surface:
- Deleted some unnecessary edges leftover from Append clothing
- Fixed finger and leg indentations caused by automated edge triangulation (toes not fixed)
- Fixed ugly shading caused by bad normals on hair and ponytail
- Set edges to 0 around cheeks, nose and mouth to fix strange edge line across the face when viewed from underneath

UV/Texture/Materials:
- Edited the textures to change colours and re-applied light makeup to the face
- Remapped UVs and combined some textures (does not support the normal map for the one-piece dress)
- Fixed some UV and texture errors (eg. fingernail, toenail)
- Fixed visible texture seams on wrists, ankles, collar
- Changed material attributes (eg. sphere maps, transparency, edge colour and thickness)
- Separated many materials for easier editing

Weights/Bones/Physics:
- Re-weighted neck, collar, shoulders, ankles
- Changed some weights to SDEF
- Added hip bone, re-did leg IKs and added IK to ponytail
- Semi-standardized the bones
- Adjusted joints, physics collision and added body and leg rigid bodies
- Fixed the parent rigid body of breast 1 joints from upper body 1 to upper body 2

Morphs:
- Re-added glasses, tongue and other morphs from TDA Miku (eg. Hachume)
- Updated and fixed many facial expression morphs errors (eg. ugly edges/clipping, slight movement of face verts that was on every morph)
- Added many sliders for shape and colour customization



[KNOWN ISSUES]
- Deformation of neck, shoulder/ciavicle, elbow and ankle areas may sometimes look strange
- There are still some automatically triangulated edges that may cause the shape of the model to look jagged from some angles (particularly on the toes)
- Knee deformation looks sharp because it lacks extra edge loops
- Combining many facial morphs can result in clipping
- When in motion, legs sometimes clip through the dress (seems to occur more often in MikuMikuMoving)
- When in motion, dress and ponytail sometimes have dark flickering edges
- Bending the upperbody bone results in a flat back area
- Some bad normals may result in inconsistently shaded surfaces
- Underwear UV has errors at the bottom
- Depending on the motion, head and neck rotation may look excessively unnatural
- Some shadow irregularities related to transparencies (eg. tights fade)
- Ponytail weights may be a little strange (particularly at the ends)
- When in motion, Neru sometimes grabs and holds onto her ponytail
- When feet are in flat position, toe EX bones won't rotate the toes properly
- Miku Miku Online version is outdated
- In certain poses, the start of the ponytail bends strangely


[TOOLS USED]
- PMD Editor 0.1.3.8 by KyokuhokuP
- PMD Editor plug-ins:
	- Check Basic Bone, Look IK plug-in by t0r0
	- IKMakerX by PaperGuitar
	- Semi Standard Bones by Soboro
	- Grid Editor by Furia
	- TransferWeights
	- Puchi Assorted Functions by SionF
	- SDEF Select Script by KyokuhokuP
	- Edge Editing Tool
	- MQO Import/Export by b2ox
	- 3ds Max Import/Export script by MarioKart64n
- Adobe Photoshop CS5.1, 6
- Autodesk 3ds Max 2013
- Autodesk Maya 2013
- Autodesk Mudbox 2013
- Metasequoia by O.Mizno
- UltraEdit
- JWPce



[ADDITIONAL INFORMATION]
This link explains the origin of Neru Akita in full detail:
http://fanloid.wikia.com/wiki/Boukaloid



[SPECIAL THANKS]
- Hanayama Tohru (helped me out a lot)
- PAC, Rosshi/BilliardP, Toro, <D>, esata, wepon, pengin (advertising my MMD Cup 9 video)
- Ranshi (testing and feedback)
- Yuuein, Kayochin, AKI, Akuma no Tsubasa, Ecodere (encouraging comments)
- Orochi Herman (invitation to Nyappon)
- ThirstyFly, ComboChef (feedback)
- GRW, Peach Mizuki (encouragement and support)
- Every person who has and will view, favorite, advertise and make positive or reasonable comments on my work
- All the people who've given me encouraging comments
- Everyone who has made and continues to make MikuMikuDance a great and enjoyable experience



[VERSION HISTORY]
1.00 (2013/01/01)	Public release

1.01 (2013/01/01)	Fixed the weights of the heart and starry-eyed eye morphs

1.02 (2013/01/01)	Customize: Added a chin shape morph, fixed visible edges on cheeks when seen from below

1.03 (2013/05/04)	Changed eye and eyelash color, and darkened outline of eyebrows
			Fixed Y pos of breast bones/joints
			Adjusted skirt and lower body rigid bodies to try and fix the waist-back and front-legs clipping
			First row of skirt rigid bodies now ignores the ponytail

2.00 (2013/05/24)	Customize: added slant5 morph, fixed hair ribbon size
			Raised eyelash ends upwards
			Made chin shape a little pointier
			Adjusted shape of jaw slightly
			Closed visible gap between mouth and inner mouth
			Fixed shape of lip morph "a"
			Added three mouth morphs, "up", "down" and "forward"
			Added a slider for preferred face preset
			Fixed arm and hand texture inconsistencies
			Changed arm, shoulder and neck bone positions
			Adjusted shoulder/neck weights
			Fixed eye highlight settings for AutoLuminous
			Changed eye texture slightly

3.00 (2013/06/25)	Customize: added new eyelash sliders
			Adjusted the weights, rigid bodies, joints and triangulation of the ponytail
			Updated the skin texture
			Changed the shape and texture of the chest area
			Customize: added a slider of the old chest shape

4.00 (2013/11/01)	Slightly darkened hair1.tga and hair2.tga
			Changed the eyelash texture to have a soft gradient
			Completely changed the eye texture
			Replaced eye highlight "MikuAppend" text with "NeruAkita"
			Fixed all problems with heart/star morphs when combined with eye morphs
			Widened and moved ahoge downwards slightly
			Adjusted physics joint limits of ahoge
			Customize: added ahoge width slider
			Customize: glasses color no longer affects lens
			Added glasses from "off" outfit

by vk