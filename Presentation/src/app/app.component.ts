import { Component, OnInit, inject } from '@angular/core';
import { UserModel } from './models/user.model';
import { AppService } from './app.service';

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
