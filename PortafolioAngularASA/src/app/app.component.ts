import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import PortafolioComponent from "./portafolio/portafolio.component";

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [RouterOutlet, PortafolioComponent]
})
export class AppComponent {
  title = 'PortafolioAngularASA';

  constructor(){}

  ngOnInit(): void{}
}
