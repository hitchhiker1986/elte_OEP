namespace Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CargoBay cb1 = new CargoBay(5);
            Tank t1 = new Tank(50, 50);
            Vehicle v1 = new Vehicle(8, t1, cb1);
            Courier courier1 = new Courier(v1, "Budapest, Gabor Denes utca 2");
            Parcel p1 = new Parcel("Zalaegerszeg, Fo ut 198");
        }
    }
}

/*
 functions:
    CargoBay
        putIn           - done
        takeOut         - done
        isEnoughSpace   - done
        isEmpty         - done
        choose          - done

    Parcel
        getAddress      - done

    Courier
        works           - done
        back            - x
        delivers        - done
        drives          - done
        picksUp         - ???

    Vehicle
        check           - done
        refuel          - done
        drive           - done
        distance        - done

    Tank
        getFuelLevel    - done
        fuelLoss        - done
        charge          - done

    KONSTRUKTOROK!!!
 */