export interface Vehicle {
    id?: string;
    make: string;
    year: string;
    color?: string;
    price?: number;
    hasSunroof? : boolean;
    isFourWheelDrive? : boolean;
    hasLowMiles? : boolean;
    hasPowerWindows? : boolean;
    hasNavigation? : boolean;
    hasHeatedSeats? : boolean;
}