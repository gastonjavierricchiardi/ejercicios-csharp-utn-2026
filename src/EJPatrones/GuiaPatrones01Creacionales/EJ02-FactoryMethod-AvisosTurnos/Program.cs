var appointment = new Appointment();

appointment.Confirm(new SmsCreator().CreateNotification());
appointment.Confirm(new EmailCreator());