using System;
using System.Security.Cryptography.X509Certificates;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager(int score)
    {
        _score = score;
        List<Goal> _goals;
    }
}