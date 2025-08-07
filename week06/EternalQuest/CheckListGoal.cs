public class CheckListGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, int targetCount, int BonusPoint) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = BonusPoint;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            return _currentCount == _targetCount ? _points + _bonusPoints : _points;
        }
        return 0;
    }
    
    public override string GetStatus() => $"[{(IsComplete() ? "x" : " ")}] {_currentCount}/{_targetCount}";
    public override bool IsComplete() => _currentCount >= _targetCount;
    public override string Serialize() => $"Check List: {_name}, {_description}, {_points}, {_targetCount}, {_bonusPoints}, {_currentCount}";
}