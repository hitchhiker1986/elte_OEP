namespace Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CargoBay cb1 = new CargoBay(5);
            Tank t1 = new Tank(50, 50);
            Vehicle v1 = new Vehicle(3, t1, cb1);
            Courier courier1 = new Courier(v1, "Budapest");
            Parcel p1 = new Parcel("Vac");
            Parcel p2 = new Parcel("Debrecen");
            Parcel p3 = new Parcel("Gyor");
            Parcel p4 = new Parcel("Kaposvar");
            Parcel p5 = new Parcel("Pecs");
            cb1.putIn(p5);
            cb1.putIn(p1);
            cb1.putIn(p1);
            cb1.putIn(p3);
            courier1.works();
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