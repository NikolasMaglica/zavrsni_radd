import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Vehicle } from 'src/app/models/vehicle.model';
import { AuthenticationService } from 'src/app/services/authentication.service';
import { ClientsService } from 'src/app/services/clients.service';
import { VehicleTypeService } from 'src/app/services/vehicle-type.service';
import { VehicleService } from 'src/app/services/vehicle.service';

@Component({
  selector: 'app-vehicle-list',
  templateUrl: './vehicle-list.component.html',
  styleUrls: ['./vehicle-list.component.css']
})
export class VehicleListComponent implements OnInit {

  
  vehicles:Vehicle[]=[];
VehicleList$!:Observable<any[]>;
ClientId$!:Observable<any[]>;

Vehicle_TypeList$!:Observable<any[]>;
vehicle_typeList:any=[];
client:any=[];

  VehicleTypesMap:Map<number, string> = new Map()
  clientTypesMap:Map<number, string> = new Map()

  activateAddEditOfferComponent:boolean=false;
  VehicleDetalils:Vehicle={
  vehicleId:'',
  manufacturer:'',
  model:'',
  productionYear:0,
  kilometersTraveled:0,
  vehicle_typeFK:'',
  clientFK:''
  }
  

  
  constructor(private snackBar: MatSnackBar, private authenticationService: AuthenticationService, private clientService:ClientsService, private router:Router,private vehicleService:VehicleService, private vehicleTypeService:VehicleTypeService) { }

  ngOnInit(): void {
    this.refreshVehicle_TypeMap();
    this.refreshUClientMap();
    this.VehicleList$=this.vehicleService.getAllVehicles();

this.vehicleService.getAllVehicles().subscribe({
  next:(vehicles)=>{
    this.vehicles=vehicles;
  },
  error:(response)=>{
    console.log(response);
  }
});
  }
  delete(item:any) {
    if(confirm(`Želite li izbirsati vozilo pod rednim brojem ${item.vehicleId} ?`)) {
      this.vehicleService.deleteVehicle(item.vehicleId).subscribe(
        (result) => {     
          this.VehicleList$=this.vehicleService.getAllVehicles();
            this.snackBar.open('Uspješno ste izbrisali vozilo', 'Zatvori');
            this.router.navigate(['vehiclelist']);
        },
        (error: HttpErrorResponse) => {
                 this.handleFailedAuthentication(error);

        }
    );
    }
  
}
private handleFailedAuthentication(error: HttpErrorResponse): void {
  let errorsMessage = [];

  let validationErrorDictionary = JSON.parse(JSON.stringify(error.error.errors));
  for (let fieldName in validationErrorDictionary) {
    if (validationErrorDictionary.hasOwnProperty(fieldName)) {
      errorsMessage.push(validationErrorDictionary[fieldName]);
    }
  }
  this.snackBar.open(errorsMessage.join(' '), 'Zatvori');
}
  refreshVehicle_TypeMap() {
    this.vehicleTypeService.getAllVehicle_Types().subscribe(data => {
      this.vehicle_typeList = data;

      for(let i = 0; i < data.length; i++)
      {
        this.VehicleTypesMap.set(this.vehicle_typeList[i].vehicle_typeId, this.vehicle_typeList[i].vehicle_typeName);
      }
    })
  }
  refreshUClientMap() {
    this.clientService.getAllClients().subscribe(data => {
      this.client=data;

      for(let i = 0; i < data.length; i++)
      {
        this.clientTypesMap.set(this.client[i].clientId, this.client[i].firstLastName);
      }
    })
  }
  logout(): void {
    this.authenticationService.logout();
  }

}
