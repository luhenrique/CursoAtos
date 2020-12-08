import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-medico',
  templateUrl: './medico.component.html',
  styleUrls: ['./medico.component.css']
})
export class MedicoComponent implements OnInit {

 title = 'Médicos'

 public medicos = [
   {id:'1',nome:'Luiz'   , especialidade:'Cardiologista', crm:'4325325', telefone:'646346343'},
   {id:'2',nome:'João'   , especialidade:'Clinico Geral', crm:'4325325', telefone:'646346343'},
   {id:'3',nome:'Cloves' , especialidade:'Psiquiatra', crm:'4325325', telefone:'646346343'}, 
   {id:'4',nome:'Cleytin', especialidade:'Podologista', crm:'4325325', telefone:'646346343'}, 
   {id:'5',nome:'Chico'  , especialidade:'Otorrinolaringologista', crm:'4325325', telefone:'646346343'}
  ]
  
  constructor() { }

  ngOnInit(): void {
  }

}
