import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { DriverService } from '../services/driver.service';
import { Driver } from '../models/driver';
import { ApiDogService } from '../services/api-dog.service';

@Component({
  selector: 'app-portafolio',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './portafolio.component.html',
  styleUrl: './portafolio.component.css'
})
export default class PortafolioComponent {
    title = 'Portafolio.App'
    drivers: Driver[]=[];
    dogImage: string = '';
    apareceImagen: boolean = true;
    constructor(private driverService: DriverService, private apiDogServivce: ApiDogService){}
  
    aparecePerro(): void{
      if(this.apareceImagen == true){
        this.apareceImagen = false;
        this.dogImage = "";
      }
      else{
        this.apareceImagen = true;
        this.apiDogServivce.getRandomDogImage().subscribe(
          image => this.dogImage = image,
          error => console.error('Error fetching random dog image:', error)
        );
      }
      console.log(this.apareceImagen)
    }

    ngOnInit(): void{
      this.driverService.getDriver().subscribe((result: Driver[]) => {
        this.drivers = result;
      });
    }
    
}
