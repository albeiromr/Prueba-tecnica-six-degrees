import { Component } from '@angular/core';

export interface User {
  usuID: number
  nombre: string;
  apellido: string;
}

const usersData: User[] = [
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
export class AppComponent {
  title = 'AlBEIRO MARIN, prueba técnica six degrees';
  displayedColumns: string[] = ['usuID', 'nombre', 'apellido'];
  dataSource = usersData;
}
