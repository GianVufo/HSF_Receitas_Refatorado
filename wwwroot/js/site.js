function inserirRemedios() { // Captura o Receituario id e o passa para o campo correspondente no formulário para registro de uma nova medicação.
  var medicId = document.querySelector(".addRec-prescriptionId").value;
  document.querySelector(".addRec-recId").value = medicId;
}

function ATM() { // na View de Receituário + ATM esta função passa para o formulário de adicionar um novo ATM o nome do paciente a receber o atestado médico
  var pacientName = document.getElementById("atm-up-pacientName").value;
  document.getElementById("atm-pacientName").value = pacientName;
}

/* Mostrar dados do paciente em tempo real em Receituário */

function ShowPrescriptionPacient() {
  var pacientName = document.getElementById("pacientName").value;
  document.querySelector('#nameP').textContent = pacientName;
}

function ShowPrescriptionData() {
  var dataAppoiment = new Date(document.getElementById("dataAppoiment").value);
  document.querySelector('#dataA').textContent = dataAppoiment.toLocaleDateString('pt-BR', { timeZone: 'UTC' });
}

function ShowPrescriptionMedic() {
  var doctorName = document.getElementById("doctorName").value;
  document.querySelector('#nameM').textContent = doctorName;
}

/* Mostrar dados do paciente em tempo real em atestado médico */

function ATMShowPrescriptionPacient() {
  var pacientName = document.getElementById("atm-pacientName").value;
  document.querySelector('#atm-nameP').textContent = pacientName;
}

function ATMShowPrescriptionData() {
  var dataAppoiment = new Date(document.getElementById("atm-dataAppoiment").value);
  document.querySelector('#atm-dataA').textContent = dataAppoiment.toLocaleDateString('pt-BR', { timeZone: 'UTC' });
}

function ATMShowPrescriptionMedic() {
  var doctorName = document.getElementById("atm-doctorName").value;
  document.querySelector('#atm-nameM').textContent = doctorName;
}

/* Mostrar dados do paciente em tempo real em atestado de comparecimento */

function ATCShowPrescriptionPacient() {
  var pacientName = document.getElementById("atc-pacientName").value;
  document.querySelector('#atc-nameP').textContent = pacientName;
}

function ATCShowPrescriptionData() {
  var dataAppoiment = new Date(document.getElementById("atc-dataAppoiment").value);
  document.querySelector('#atc-dataA').textContent = dataAppoiment.toLocaleDateString('pt-BR', { timeZone: 'UTC' });
}

function ATCShowPrescriptionMedic() {
  var doctorName = document.getElementById("atc-doctorName").value;
  document.querySelector('#atc-nameM').textContent = doctorName;
}