namespace Builder.Components;

public class Engine {
    private int _power;

    public Engine(int power) => this.Power = power;

    public int Power {
        get => this._power;
        set => this._power = value;
    }
}