CREATE SCHEMA `tower_defense` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;

CREATE TABLE `tower_defense`.`stages` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`));
  
  CREATE TABLE `tower_defense`.`monters` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `type` INT NULL,
  `hp` INT NOT NULL DEFAULT 100,
  `speed` FLOAT NOT NULL,
  `defense` INT NULL,
  `gold` INT NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_unicode_ci;

CREATE TABLE `tower_defense`.`players` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `gold` INT NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_unicode_ci;
  
  CREATE TABLE `tower_defense`.`waves` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `stageId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_wave_stageId_idx` (`stageId` ASC) VISIBLE,
  CONSTRAINT `fk_wave_stageId`
    FOREIGN KEY (`stageId`)
    REFERENCES `tower_defense`.`stages` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_unicode_ci;

CREATE TABLE `tower_defense`.`wave_info` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `time` INT NOT NULL DEFAULT 5,
  `quanlity` INT NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_unicode_ci;

CREATE TABLE `tower_defense`.`wave_detail` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `waveId` INT NOT NULL,
  `waveInfoId` INT NOT NULL,
  `monterId` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_waveDetail_monterId_idx` (`monterId` ASC) VISIBLE,
  INDEX `fk_waveDetail_waveId_idx` (`waveId` ASC) VISIBLE,
  INDEX `fk_waveDetail_waveInfoId_idx` (`waveInfoId` ASC) VISIBLE,
  CONSTRAINT `fk_waveDetail_monterId`
    FOREIGN KEY (`monterId`)
    REFERENCES `tower_defense`.`monters` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_waveDetail_waveId`
    FOREIGN KEY (`waveId`)
    REFERENCES `tower_defense`.`waves` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_waveDetail_waveInfoId`
    FOREIGN KEY (`waveInfoId`)
    REFERENCES `tower_defense`.`wave_info` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
COLLATE = utf8_unicode_ci;





