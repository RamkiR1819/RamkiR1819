using System.Collections.Generic;
using UnityEngine;

public class ChallengeManager : MonoBehaviour
{
    public List<Challenge> challenges;

    private void Start()
    {
        InitializeChallenges();
    }

    private void InitializeChallenges()
    {
        // Initialize or load challenges here
        challenges = new List<Challenge>
        {
            new Challenge("Race to the Finish", ChallengeType.Racing, 100),
            new Challenge("Fly Through the Rings", ChallengeType.Flying, 150),
            new Challenge("Perfect Parking", ChallengeType.Parking, 200),
            new Challenge("Defeat the Enemy", ChallengeType.Fighting, 250)
        };
    }

    public void CompleteChallenge(Challenge challenge)
    {
        // Logic for completing a challenge
        if (challenges.Contains(challenge))
        {
            challenges.Remove(challenge);
            Debug.Log($"Challenge Completed: {challenge.name}");
        }
    }
}

[System.Serializable]
public class Challenge
{
    public string name;
    public ChallengeType type;
    public int reward;

    public Challenge(string name, ChallengeType type, int reward)
    {
        this.name = name;
        this.type = type;
        this.reward = reward;
    }
}

public enum ChallengeType
{
    Racing,
    Flying,
    Parking,
    Fighting
}