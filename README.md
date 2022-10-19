# tgd-unity2022-tuto1

Dans ce tutoriel, nous allons voir l'installation et la mise en place de l'environnement d'unity, ainsi que l'introduction très basiques à unity. Le code ci-joint contient le code fait lors de la séance du jeudi 6 octobre 2022.
Conseil avant toute installation, Unity peut prendre pas mal de place sur vos disques durs, donc décidez bien d'où vous souhaitez installer tout ça (surtout car la machine virtuelle de l'école prend **aussi** énormément de place).

## Installation Unity

Afin d'installer Unity, rendez-vous sur la page de téléchargement du [site officiel](https://unity.com/fr/download) où vous pourrez télécharger le hub unity, permettant de gérer vos divers projets. (La licence utilisée ne coûte rien tant que vous ne gagnez pas plus de 100 000 $, pour plus de précision, cherchez par vous même mais vous ne risquez rien à TGD)

Une fois que le hub est installé, lancez le, créez votre compte unity et associez le. Ensuite, allez dans la catégorie **Installs** dans le hub, et installez l'éditeur Unity le plus récent (les versions ne changent pas grand chose tant que vous ne passez pas de la 2016 à la 2021). N'oubliez pas lors de l'installation de l'éditeur d'avoir coché le module Microsoft Visual Studio Community (on utilisera ça pour coder nos scripts, c'est pratique, mais pas obligatoire si vous avez déjà quelque chose d'efficace de votre côté **qui fonctionne**)

Maintenant, il s'agit d'associer la licence gratuite, allez dans *settings*, *license management* et activez votre licence personnelle.

Normalement, tout est bon pour l'installation !


## Installation Visual Studio Community 

Afin de coder nos scripts sur Unity et de faciliter l'écriture de code, on va utiliser Visual Studio Community (un peu différent de la version code, et surtout plus facile d'y ajouter des modules importants) et ce, sur le [site officiel](https://visualstudio.microsoft.com/fr/vs/community/).

Lors de l'installation, cochez l'ajout du module **Développement de jeu avec Unity** ainsi que ceux que vous souhaitez.


## Association Unity et VSC

Maintenant que tout est installé, on va faire en sorte qu'Unity reconnaisse VSC pour l'édition de code.
Pour ça, lancez votre premier projet (faites un projet 3D par exemple, c'est dans la suite du tuto).
Une fois l'éditeur Unity lancé, allez en haut à gauche dans **Edit**, puis **Preferences** suivi dans la fenêtre venant d'apparaître par l'onglet **External Tools** où vous sélectionnerez **Visual Studio Community** comme outil externe.


## Premier Tuto Unity !

Tout est installé et mis en place, si quelque chose ne va pas n'hésitez pas à demander sur le discord (cela dit on n'a pas la science infuse attention).
Le premier tuto unity est en code joint au tuto, libre à vous de tester les objets dans le jeu, et de poser des questions si besoin !
Une fois le code téléchargé, vous pouvez l'ouvrir dans le Hub Unity afin de pouvoir voir ce qui a été fait (dans l'éditeur, double cliquez sur la scene SampleScene si elle n'est pas directement ouverte). En lançant le jeu, vous pourrez contrôler le cube rouge avec Z,Q,S et D et pourrez le déplacer et remarquer la physique interne à Unity.

Tout d'abord, dans l'affichage d'unity, on peut voir la hiérarchie à gauche, permettant de voir tout les objets contenus dans la scène, suivi au milieu de l'éditeur, dans lequel il est possible de gérer les objets et de les déplacer et les modifier au besoin, il est également possible de lancer le jeu pour tester avec la flèche en haut de l'éditeur. Sur la partie droite se trouve l'inspecteur, permettant de regarder en détail les attributs, composants et paramètres de l'objet sélectionné.  Enfin, dans la partie inférieure, on a les assets contenant nos scripts, objets, matériels, musiques, textures etc...

Pour ce premier tuto, j'ai ajouté un 3Dobject plan afin de servir de sol, auquel j'ai ajouté par dessus deux 3Dobject cubes qui nous serviront pour la suite.
À partir d'un clic droit -> create, j'ai créé un material pour chaque cube, afin de les colorer et pouvoir les distinguer. J'ai ensuite placé convenablement la caméra au dessus du cube que j'allais considérer comme le joueur afin de pouvoir créer le script cameraControl.cs, permettant de conserver la position relative de la caméra par rapport au cube, en calculant le vecteur séparant les deux, pour ensuite dans update rattribuer ce vecteur à la position de la caméra.

Ensuite vient le déplacement de ce cube. J'ai ajouté le script NewScript.cs (nommez bien vos scripts, c'est plus simple à retrouver), auquel dans la partie update (se lançant à chaque frame) j'ai ajouté les GetKey permettant de surveiller la touche sur laquelle appuie l'utilisateur, permettant de déplacer le cube à partir d'un vecteur de déplacement si l'utlisateur appuie sur la bonne touche. On remarquera la présence du "\*Time.deltaTime;", qui permet de réduire l'effet de la touche, en effet, le maintien de la touche ajoute à chaque frame du jeu ce vecteur, propulsant notre cube extrêmement loin (essayez de retirer pour voir). 

Enfin, j'ai ajouté à notre cube ennemie dans l'inspecteur le tag "enemy" (via la création de tag dans le même onglet), ainsi qu'un rigidbody afin de pouvoir créer une collision avec. En ajoutant aussi rigidbody au cube joueur, on peut remarquer les physiques entre les cubes à chaque collision.
J'ai donc ajouté à mon code un OnCollisionEnter, fonction qui s'appelle lorsqu'un objet entre en collision avec l'objet contenant ce script. Je vérifie ensuite si l'objet en collision possède le tag "enemy" auquel cas je détruis le joueur.

C'est tout pour ce tuto de la première séance ! 

