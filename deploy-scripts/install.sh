#!/bin/bash
source /var/xigify/config
sudo rm -rf /var/www/$XIGIFYENV/testapi
sudo mkdir -p /var/www/$XIGIFYENV/testapi
sudo cp -a /var/tempbuild/code/testapi/out/. /var/www/$XIGIFYENV/testapi/
sudo cp -a /var/tempbuild/code/testapi/systemd/Xigify.testapi.$XIGIFYENV.service /etc/systemd/system
sudo cp -a /var/www/$XIGIFYENV/testapi/testapi.$XIGIFYENV.appsettings.json /var/www/$XIGIFYENV/testapi/testapi.appsettings.json 
sudo systemctl daemon-reload
sudo rm -rf /var/tempbuild/code/testapi