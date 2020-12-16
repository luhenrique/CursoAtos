import { Component, OnInit } from '@angular/core';
import { disableDebugTools } from '@angular/platform-browser';
import { Medico } from '../models/Medico';

@Component({
  selector: 'app-medico',
  templateUrl: './medico.component.html',
  styleUrls: ['./medico.component.css']
})
export class MedicoComponent implements OnInit {

 titleMedico = 'Médicos'

 public selectedMedico: Medico;

 public medicos = [
   {id:'1',nome:'Luiz'   , especialidade:'Cardiologista', crm:'4325325', telefone:'646346343'},
   {id:'2',nome:'João'   , especialidade:'Clinico Geral', crm:'4325325', telefone:'646346343'},
   {id:'3',nome:'Cloves' , especialidade:'Psiquiatra', crm:'4325325', telefone:'646346343'}, 
   {id:'4',nome:'Cleytin', especialidade:'Podologista', crm:'4325325', telefone:'646346343'}, 
   {id:'5',nome:'Chico'  , especialidade:'Otorrinolaringologista', crm:'4325325', telefone:'646346343'}
  ]
  
  selectMedico(medico: Medico){
    this.selectedMedico = medico;
  }

  back(){
    this.selectedMedico = null;
  }


  constructor() { }

  ngOnInit(): void {
  }

}




