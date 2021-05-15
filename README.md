# daikin
This is a small project which should help to get the correct description for all daikin parameters

in the c# project change url to the correct api response

For more informations see:
https://github.com/ael-code/daikin-control
https://github.com/Apollon77/daikin-controller

For loxone integartion:
https://www.loxwiki.eu/display/LOXEN/Integration+of+Daikin+Air+Conditioning+over+WiFi

# Parameter Example / Description

ret=OK
pow=1
mode=0 // 0 Auto, 2 dehumidify, 3 cool, 4 heat, 6 fan
adv=2 // Powermode = 2
stemp=18.0 // target temperature
shum=0
dt1=18.0 // mode 1 ? temperatur
dt2=M // mode 2 temperature (dehumidify has no temperature)
dt3=20.0 // cool temperature
dt4=25.0 // heat temperature
dt5=25.0 // fan tempature (we does it have one?)
dt7=18.0 // 
dh1=0
dh2=50
dh3=0
dh4=0
dh5=0
dh7=0
dhh=50
b_mode=0 // current mode (see mode parameter for options)
b_stemp=18.0 // current temperature
b_shum=0
alert=255
f_rate=A // target fan rate (A means auto)
f_dir=0 // target direction for swing // 0 no swing 1 swing vertical 2 swing horizontal 3 swing both
b_f_rate=A  // current fan rate
b_f_dir=0 // current target direction for swing (see f_dir paramter for modes)
dfr1=A
dfr2=5
dfr3=A
dfr4=5
dfr5=5
dfr6=5
dfr7=A
dfrh=5
dfd1=0
dfd2=0
dfd3=0
dfd4=0
dfd5=0
dfd6=0
dfd7=0
dfdh=0
dmnd_run=0
en_demand=0