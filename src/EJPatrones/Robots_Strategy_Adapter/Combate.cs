using System;

public class Combate
{
    private Robot robot1;
    private Robot robot2;

    public Combate(Robot robot1, Robot robot2)
    {
        this.robot1 = robot1 ?? throw new ArgumentNullException(nameof(robot1));
        this.robot2 = robot2 ?? throw new ArgumentNullException(nameof(robot2));

        if (ReferenceEquals(robot1, robot2))
        {
            throw new ArgumentException("Deben combatir dos robots distintos.");
        }
    }

    public Robot? Simular()
    {
        Robot atacante = robot1;
        Robot defensor = robot2;

        while (robot1.EstaOperativo() && robot2.EstaOperativo())
        {
            atacante.Atacar(defensor);

            Robot temporal = atacante;
            atacante = defensor;
            defensor = temporal;
        }

        if (robot1.EstaOperativo())
        {
            return robot1;
        }

        if (robot2.EstaOperativo())
        {
            return robot2;
        }

        return null;
    }
}
