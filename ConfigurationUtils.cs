using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    static ConfigurationData configurationData;
    static int difficulty;

    #region Properties

    /// <summary>
    /// Gets the player move units per second
    /// </summary>
    /// <value>player move units per second</value>
    public static float PlayerMoveUnitsPerSecond
    {
        get { return configurationData.PlayerMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the jump value
    /// </summary>
    /// <value>jump force</value>
    public static float JumpForce
    {
        get { return configurationData.JumpForce; }
    }

    /// <summary>
    /// Gets the player bullet speed value
    /// </summary>
    /// <value>player bullet speed</value>
    public static float PlayerBulletSpeed
    {
        get { return configurationData.PlayerBulletSpeed; }
    }

    /// <summary>
    /// Gets the enemy bullet speed value
    /// </summary>
    /// <value>enemy bullet speed</value>
    public static float EnemyBulletSpeed
    {
        get { return configurationData.EnemyBulletSpeed; }
    }

    /// <summary>
    /// Gets the player health value
    /// </summary>
    /// <value>Player Health</value>
    public static int PlayerHealth
    {
        get { return configurationData.PlayerHealth; }
    }

    /// <summary>
    /// Gets the player lives value
    /// </summary>
    /// <value>Player Lives</value>
    public static int PlayerLives
    {
        get { return configurationData.PlayerLives; }
    }

    /// <summary>
    /// Gets the enemy health value
    /// </summary>
    /// <value>Enemy Health</value>
    public static int EnemyHealth
    {
        get { return configurationData.EnemyHealth; }
    }

    /// <summary>
    /// Gets the player bullet damage value
    /// </summary>
    /// <value>Player Bullet Damage</value>
    public static int PlayerBulletDamage
    {
        get { return configurationData.PlayerBulletDamage; }
    }

    /// <summary>
    /// Gets the enemy bullet damage value
    /// </summary>
    /// <value>Player Bullet Damage</value>
    public static int EnemyBulletDamage
    {
        get { return configurationData.EnemyBulletDamage; }
    }

    public static int Difficulty
    {
        get { return difficulty; }
        set { difficulty = value; }
    }

    /// <summary>
    /// Gets the player fire cooldown value
    /// </summary>
    /// <value>Player Cooldown Fire</value>
    public static float PlayerCooldownFire
    {
        get { return configurationData.PlayerCooldownFire; }
    }

    /// <summary>
    /// Gets the shield effect duration value
    /// </summary>
    /// <value>Shield Effect Duration</value>
    public static float ShieldEffect
    {
        get { return configurationData.ShieldEffect; }
    }

    /// <summary>
    /// Gets the double damage duration value
    /// </summary>
    /// <value>Double Damage Duration</value>
    public static float DoubleDamageEffect
    {
        get { return configurationData.DoubleDamageEffect; }
    }

    #endregion

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }

}
