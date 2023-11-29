CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS sports(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        name CHAR(225) NOT NULL,
        teams INT NOT NULL,
        inAmerica BOOL NOT NULL DEFAULT true,
        watchable BOOL NOT NULL DEFAULT false
    ) default charset utf8 COMMENT '';

SELECT * FROM sports

INSERT INTO
    sports (
        name,
        teams,
        `inAmerica`,
        watchable
    )
VALUES
("NBA", 32, true, true), ('MLB', 32, false, true), ('NHL', 30, false, true)

DROP TABLE sports