CREATE TABLE IF NOT EXISTS `EESLP`.`Host` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `Hostname` VARCHAR(50) NOT NULL,
  `FQDN` VARCHAR(250) NOT NULL,
  `ApiKey` VARCHAR(250) NOT NULL,
  `CreatedDateTime` DATETIME NULL,
  `LastModDateTime` DATETIME NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `FQDN_UNIQUE` (`FQDN` ASC),
  INDEX `ApiKey_INDEX` (`ApiKey` ASC))
ENGINE = InnoDB

CREATE TABLE IF NOT EXISTS `EESLP`.`Script` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `Scriptname` VARCHAR(50) NOT NULL,
  `Description` TEXT NULL,
  `CreatedDateTime` DATETIME NULL,
  `LastModDateTime` DATETIME NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `ScriptName_UNIQUE` (`Scriptname` ASC))
ENGINE = InnoDB