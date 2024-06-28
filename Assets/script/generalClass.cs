using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generalClass
{

    public Enemy enemy1;
    public Bullet bullet1;
    public Player player1; 

    public class Enemy
    {
        public float enemySpeed                 {get; set;}
        public float enemyDamage                {get; set;}
        public float enemyLife                  {get; set;}
        public float enemyRecule                {get; set;}

        public Enemy()
        {
            this.enemySpeed                     = 2f;
            this.enemyDamage                    = 10f;
            this.enemyLife                      = 100f;
            this.enemyRecule                    = 100f;
        }
    }

    public class Bullet
    {
        public float bulletSpeed                {get; set;}
        public float bulletDamage               {get; set;}

        public Bullet()
        {
            this.bulletDamage                   = 20f;
            this.bulletSpeed                    = 20f;
        }
    }

    public class Player
    {
        public float playerSpeed                {get; set;}
        public float playerLife                 {get; set;}
        public float playerRotationSensitivity  {get; set;}

        public Player()
        {
            this.playerSpeed                    = 3.3f;         //vitesse marche 1.3f, vitesse course d'endurance 3.3f et vitesse sprint 6.9f
            this.playerLife                     = 100f;
            this.playerRotationSensitivity      = 150f;           //pour une unité de déplacement de la souris le personnage tourneras de playerRotationSensitivity°
        }
    }

    public class BaseCamera
    {
        public float cameraRotationSensitivity  {get; set;}

        public BaseCamera()
        {
            this.cameraRotationSensitivity      = 150f;           //pour une unité de déplacement de la souris le personnage tourneras de playerRotationSensitivity°
        }
    }

}
