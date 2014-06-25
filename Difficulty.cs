using System;

public class Difficulty
{

    public static readonly Difficulty _easyMode = new Difficulty(3, 5, 10);
    public static readonly Difficulty _mediumMode = new Difficulty(3, 8, 14);
    private static readonly Dificulty _hardMode = new Difficult(6, 8, 15);
    private int _numberOfBits;
    private int _baseNumber;
    private int _numberOfTurns;

    public Difficulty(int bits, int baseNum, int turns) {
        _numberOfBits = bits;
        _baseNumber = baseNum;
        _numberOfTurns = turns;
    }

    public static Difficulty getEasy()
    {
        return _easyMode;

    }

    public static Difficulty getMedium()
    {
        return _mediumMode;
    }

    public static Difficulty getHard()
    {
        return _hardMode;
    }

    public int numberOfBits {
        get { return this._numberOfBits; } 
    }

    public int baseNumber {
        get { return this._baseNumber; }
    }

    public int numberOfTurns
    {
        get { return this._numberOfTurns; }
    }
}
