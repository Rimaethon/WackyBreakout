﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "configurationData.csv";

    // configuration data
    float paddleMoveUnitsPerSecond = 10;
    float ballImpulseForce = 200;
    float ballLifeSeconds = 10;
    float minSpawnSeconds = 5;
    float maxSpawnSeconds = 10;
    int ballsPerGame = 5;
    int standardBlockPoints = 1;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public float PaddleMoveUnitsPerSecond
    {
        get { return paddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public float BallImpulseForce
    {
        get { return ballImpulseForce; }    
    }

    /// <summary>
    /// Gets the number of seconds the ball lives
    /// </summary>
    /// <value>ball life seconds</value>
    public float BallLifeSeconds
    {
        get { return ballLifeSeconds; }
    }

    /// <summary>
    /// Gets the minimum number of seconds for a ball spawn
    /// </summary>
    /// <value>minimum spawn seconds</value>
    public float MinSpawnSeconds
    {
        get { return minSpawnSeconds; }
    }

    /// <summary>
    /// Gets the maximum number of seconds for a ball spawn
    /// </summary>
    /// <value>maximum spawn seconds</value>
    public float MaxSpawnSeconds
    {
        get { return maxSpawnSeconds; }
    }

    public int BallsPerGame
    {
        get { return ballsPerGame; }
    }

    /// <summary>
    /// Gets how many points a standard block is worth
    /// </summary>
    public int StandardBlockPoints
    {
        get { return standardBlockPoints; }
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        StreamReader input = null;
        try
        {
            input = File.OpenText(Path.Combine(Application.streamingAssetsPath, ConfigurationDataFileName));
            string names = input.ReadLine();
            string values = input.ReadLine();
            SetConfigurationDataFields(values);
        }
        catch(Exception e)
        {
        }
        finally
        {
            if(input!=null)
            {
                input.Close();
            }
        }
    }

    #endregion

    #region Private Methods
    void SetConfigurationDataFields(string csvValues)
    {
        string[] values = csvValues.Split(',');
        paddleMoveUnitsPerSecond = float.Parse(values[0]);
        ballImpulseForce = float.Parse(values[1]);
        ballLifeSeconds = float.Parse(values[2]);
        minSpawnSeconds = float.Parse(values[3]);
        maxSpawnSeconds = float.Parse(values[4]);
        ballsPerGame = int.Parse(values[5]);
        standardBlockPoints = int.Parse(values[6]);
    }
    #endregion
}
