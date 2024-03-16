import { Component, OnInit, inject } from '@angular/core';
import { UserModel } from './models/user.model';
import { AppService } from './app.service';



const usersData: UserModel[] = [
  { usuID: 1, nombre: 'Hydrogen', apellido: 'H' },
  { usuID: 2, nombre: 'Helium', apellido: 'He' },
  { usuID: 3, nombre: 'Lithium', apellido: 'Li' },
  { usuID: 4, nombre: 'Beryllium', apellido: 'Be' },
  { usuID: 5, nombre: 'Boron', apellido: 'B' },
];

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
})
export class AppComponent{  
  title = 'AlBEIRO MARIN, prueba técnica SIX DEGRRES IT';
  displayedColumns: string[] = ['usuID', 'nombre', 'apellido'];
  dataSource: UserModel[] = [];

  private _appService = inject(AppService);

  getData(): void {
    this._appService.getServerData().subscribe(data => {
      if (data.success)
        this.dataSource = data.data
      else
        console.log("Hubo un error al consultar los datos")
    })
  }

}
