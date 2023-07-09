function AddMedications() {

  let properties = {
    Id: $("#medicationId").val(),
    MedicationName: $("#medicationName").val(),
    Presentation: $("#presentation").val(),
    RouteOfAdministration: $("input[type=radio][name=administration]:checked").val(),
    Posology: $("#posology").val(),
    DurationOfTreatment: $("#durationTreatment").val(),
    ReceituarioId: $(".addRec-recId").val(),
  };

  if(properties.RouteOfAdministration == "outros")
  {
    properties.RouteOfAdministration = $("#other").val();
  }

  $.post("/Medicacao/MedicationRegister", properties)

    .done(function (output) {
      if (output.stats == "OK") {

        alert("Medicação: " + properties.MedicationName + " - " + properties.Presentation + " cadastrada com sucesso!")
        //$(location).attr('href', '/Receituario/CompletePrescription?id=' + parseInt(properties.ReceituarioId));
        location.reload();

      } else if (output.stats == "INVALID") {
        $(".alerta").html('<div class="alert alert-danger"> Não foi possível cadastrar essa medicação. Tente mais tarde!</div>');

      }

    })

    .fail(function () {
      alert("Falha ao adicionar medicamento!");
    });
}

$(document).ready(function () {
  $("#medic-form").submit(function (e) {
    e.preventDefault();
    AddMedications();
  });
});

// $(document).ready(function() {
//   $('.teste-btn').click(function() {
//       var value = $("input[type=radio][name=administration]:checked").val();
//       if (value) {
//           alert(value);
//       }
//       else {
//           alert('Nothing is selected');
//       }
//   })
// });